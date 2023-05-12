package com.KRM3D.adultquestiontitleservice.services.impl;

import com.KRM3D.adultquestiontitleservice.entities.AdultQuestionTitle;
import com.KRM3D.adultquestiontitleservice.repositories.AdultQuestionTitleRepository;
import com.KRM3D.adultquestiontitleservice.services.AdultQuestionTitleService;
import com.KRM3D.adultquestiontitleservice.services.dto.CreatedAdultQuestionTitleDto;
import com.KRM3D.adultquestiontitleservice.services.dto.DeletedAdultQuestionTitleDto;
import com.KRM3D.adultquestiontitleservice.services.dto.UpdatedAdultQuestionTitleDto;
import com.KRM3D.adultquestiontitleservice.services.rules.AdultQuestionTitleRules;
import com.KRM3D.adultquestiontitleservice.services.streams.AdultQuestionTitlePublishChannel;
import org.modelmapper.ModelMapper;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.cloud.stream.annotation.EnableBinding;
import org.springframework.messaging.support.MessageBuilder;
import org.springframework.stereotype.Service;

@Service
@EnableBinding(AdultQuestionTitlePublishChannel.class)
public class AdultQuestionTitleServiceImpl implements AdultQuestionTitleService {
    private AdultQuestionTitleRepository adultQuestionTitleRepository;
    private ModelMapper modelMapper;
    private AdultQuestionTitleRules adultQuestionTitleRules;
    private AdultQuestionTitlePublishChannel adultQuestionTitlePublishChannel;
    @Autowired
    public AdultQuestionTitleServiceImpl(AdultQuestionTitleRepository adultQuestionTitleRepository, ModelMapper modelMapper, AdultQuestionTitleRules adultQuestionTitleRules, AdultQuestionTitlePublishChannel adultQuestionTitlePublishChannel) {
        this.adultQuestionTitleRepository = adultQuestionTitleRepository;
        this.modelMapper = modelMapper;
        this.adultQuestionTitleRules = adultQuestionTitleRules;
        this.adultQuestionTitlePublishChannel = adultQuestionTitlePublishChannel;
    }
    @Override
    public CreatedAdultQuestionTitleDto add(CreatedAdultQuestionTitleDto adultQuestionTitleDto) {
        var mappedAdultQuestionTitles = this.modelMapper.map(adultQuestionTitleDto, AdultQuestionTitle.class);
        this.adultQuestionTitleRules.DoToUpper(mappedAdultQuestionTitles);
        this.adultQuestionTitleRules.DoTrim(mappedAdultQuestionTitles);
        this.adultQuestionTitleRepository.save(mappedAdultQuestionTitles);
        this.adultQuestionTitlePublishChannel.createOutputChannel().send(MessageBuilder.withPayload(mappedAdultQuestionTitles).build());
        return adultQuestionTitleDto;
    }

    @Override
    public UpdatedAdultQuestionTitleDto update(UpdatedAdultQuestionTitleDto adultQuestionTitle) {
        var mappedAdultQuestionTitles = this.modelMapper.map(adultQuestionTitle, AdultQuestionTitle.class);
        this.adultQuestionTitleRules.DoToUpper(mappedAdultQuestionTitles);
        this.adultQuestionTitleRules.DoTrim(mappedAdultQuestionTitles);
        this.adultQuestionTitleRepository.save(mappedAdultQuestionTitles);
        this.adultQuestionTitlePublishChannel.updateOutputChannel().send(MessageBuilder.withPayload(mappedAdultQuestionTitles).build());
        return adultQuestionTitle;
    }

    @Override
    public DeletedAdultQuestionTitleDto delete(String id) {
        var getId = this.adultQuestionTitleRepository.findById(id).get();
        this.adultQuestionTitleRepository.delete(getId);
        this.adultQuestionTitlePublishChannel.deleteOutputChannel().send(MessageBuilder.withPayload(getId).build());
        var result = this.modelMapper.map(getId, DeletedAdultQuestionTitleDto.class);
        return result;
    }
}

