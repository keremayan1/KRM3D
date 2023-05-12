package com.KRM3D.adultquestionservice.services.impl;

import com.KRM3D.adultquestionservice.entities.AdultQuestion;
import com.KRM3D.adultquestionservice.repositories.AdultQuestionRepository;
import com.KRM3D.adultquestionservice.services.AdultQuestionService;
import com.KRM3D.adultquestionservice.services.dtos.CreatedAdultQuestionDto;
import com.KRM3D.adultquestionservice.services.dtos.DeletedAdultQuestionDto;
import com.KRM3D.adultquestionservice.services.dtos.UpdatedAdultQuestionDto;
import com.KRM3D.adultquestionservice.services.rules.AdultQuestionRules;
import com.KRM3D.adultquestionservice.services.streams.AdultQuestionPublishChannel;
import org.modelmapper.ModelMapper;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.cloud.stream.annotation.EnableBinding;
import org.springframework.messaging.support.MessageBuilder;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
@EnableBinding(AdultQuestionPublishChannel.class)
public class AdultQuestionServiceImpl implements AdultQuestionService {
    private AdultQuestionRepository adultQuestionRepository;
    private ModelMapper modelMapper;
    private AdultQuestionRules adultQuestionRules;
    private AdultQuestionPublishChannel adultQuestionPublishChannel;
    @Autowired
    public AdultQuestionServiceImpl(AdultQuestionRepository adultQuestionRepository, ModelMapper modelMapper, AdultQuestionRules adultQuestionRules, AdultQuestionPublishChannel adultQuestionPublishChannel) {
        this.adultQuestionRepository = adultQuestionRepository;
        this.modelMapper = modelMapper;
        this.adultQuestionRules = adultQuestionRules;
        this.adultQuestionPublishChannel = adultQuestionPublishChannel;
    }

    @Override
    public CreatedAdultQuestionDto add(CreatedAdultQuestionDto adultQuestion) {
        var mappedAdultQuestions = this.modelMapper.map(adultQuestion, AdultQuestion.class);
        this.adultQuestionRules.DoToUpper(mappedAdultQuestions);
        this.adultQuestionRules.DoTrim(mappedAdultQuestions);
        this.adultQuestionRepository.save(mappedAdultQuestions);
        this.adultQuestionPublishChannel.createOutputChannel().send(MessageBuilder.withPayload(mappedAdultQuestions).build());
        return  adultQuestion;
    }

    @Override
    public UpdatedAdultQuestionDto update(UpdatedAdultQuestionDto adultQuestion) {
        var mappedAdultQuestions = this.modelMapper.map(adultQuestion, AdultQuestion.class);
        this.adultQuestionRules.DoToUpper(mappedAdultQuestions);
        this.adultQuestionRules.DoTrim(mappedAdultQuestions);
        this.adultQuestionRepository.save(mappedAdultQuestions);
        this.adultQuestionPublishChannel.updateOutputChannel().send(MessageBuilder.withPayload(mappedAdultQuestions).build());
        return  adultQuestion;
    }

    @Override
    public DeletedAdultQuestionDto delete(String id) {
        var getId = this.adultQuestionRepository.findById(id).get();
        this.adultQuestionRepository.delete(getId);
        var result = this.modelMapper.map(getId, DeletedAdultQuestionDto.class);
        this.adultQuestionPublishChannel.deleteOutputChannel().send(MessageBuilder.withPayload(getId).build());
        return result;
    }

    @Override
    public List<AdultQuestion> getAll() {
        return  this.adultQuestionRepository.findAll();
    }
}
