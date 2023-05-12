package com.KRM3D.adultquestionanswerservice.services.impl;

import com.KRM3D.adultquestionanswerservice.entities.AdultQuestionAnswer;
import com.KRM3D.adultquestionanswerservice.repositories.AdultQuestionAnswerRepository;
import com.KRM3D.adultquestionanswerservice.services.AdultQuestionAnswerService;
import com.KRM3D.adultquestionanswerservice.services.dtos.CreatedAdultQuestionAnswerDto;
import com.KRM3D.adultquestionanswerservice.services.dtos.DeletedAdultQuestionAnswerDto;
import com.KRM3D.adultquestionanswerservice.services.dtos.UpdatedAdultQuestionAnswerDto;
import com.KRM3D.adultquestionanswerservice.services.rules.AdultQuestionAnswerRules;
import com.KRM3D.adultquestionanswerservice.services.streams.AdultQuestionAnswerPublishChannel;
import org.modelmapper.ModelMapper;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.cloud.stream.annotation.EnableBinding;
import org.springframework.messaging.support.MessageBuilder;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
@EnableBinding(AdultQuestionAnswerPublishChannel.class)
public class AdultQuestionAnswerServiceImpl implements AdultQuestionAnswerService {
    private AdultQuestionAnswerRepository adultQuestionAnswerRepository;
    private ModelMapper modelMapper;
    private AdultQuestionAnswerRules adultQuestionAnswerRules;
    private AdultQuestionAnswerPublishChannel adultQuestionAnswerPublishChannel;

    @Autowired
    public AdultQuestionAnswerServiceImpl(AdultQuestionAnswerRepository adultQuestionAnswerRepository, ModelMapper modelMapper, AdultQuestionAnswerRules adultQuestionAnswerRules, AdultQuestionAnswerPublishChannel adultQuestionAnswerPublishChannel) {
        this.adultQuestionAnswerRepository = adultQuestionAnswerRepository;
        this.modelMapper = modelMapper;
        this.adultQuestionAnswerRules = adultQuestionAnswerRules;
        this.adultQuestionAnswerPublishChannel = adultQuestionAnswerPublishChannel;
    }

    @Override
    public List<CreatedAdultQuestionAnswerDto> addAll(List<CreatedAdultQuestionAnswerDto> createdAdultQuestionAnswer) {
        for (var createdAdultQuestionAnswers:createdAdultQuestionAnswer) {
            var mappedAdultQuestionAnswer = this.modelMapper.map(createdAdultQuestionAnswers,AdultQuestionAnswer.class);
            this.adultQuestionAnswerRules.DoToUpper(mappedAdultQuestionAnswer);
            this.adultQuestionAnswerRules.DoToTrim(mappedAdultQuestionAnswer);
            this.adultQuestionAnswerRepository.save(mappedAdultQuestionAnswer);
            this.adultQuestionAnswerPublishChannel.createOutputChannel().send(MessageBuilder.withPayload(mappedAdultQuestionAnswer).build());

        }
        return createdAdultQuestionAnswer;


    }

    @Override
    public UpdatedAdultQuestionAnswerDto update(UpdatedAdultQuestionAnswerDto updatedAdultQuestionAnswerDto) {
        var mappedAdultQuestionAnswer = this.modelMapper.map(updatedAdultQuestionAnswerDto,AdultQuestionAnswer.class);
        this.adultQuestionAnswerRules.DoToUpper(mappedAdultQuestionAnswer);
        this.adultQuestionAnswerRules.DoToTrim(mappedAdultQuestionAnswer);
        this.adultQuestionAnswerRepository.save(mappedAdultQuestionAnswer);
        this.adultQuestionAnswerPublishChannel.updateOutputChannel().send(MessageBuilder.withPayload(mappedAdultQuestionAnswer).build());
        return  updatedAdultQuestionAnswerDto;
    }

    @Override
    public DeletedAdultQuestionAnswerDto delete(String id) {
      var getId = this.adultQuestionAnswerRepository.findById(id).get();
      this.adultQuestionAnswerRepository.delete(getId);
      this.adultQuestionAnswerPublishChannel.deleteOutputChannel().send(MessageBuilder.withPayload(getId).build());
      var result = this.modelMapper.map(getId,DeletedAdultQuestionAnswerDto.class);
      return  result;
    }

    @Override
    public List<AdultQuestionAnswer> getAll() {
        return this.adultQuestionAnswerRepository.findAll();
    }
}
