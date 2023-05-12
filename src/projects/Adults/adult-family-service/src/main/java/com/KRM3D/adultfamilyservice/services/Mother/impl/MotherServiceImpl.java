package com.KRM3D.adultfamilyservice.services.Mother.impl;

import com.KRM3D.adultfamilyservice.entities.Mother;
import com.KRM3D.adultfamilyservice.repositories.MotherRepository;
import com.KRM3D.adultfamilyservice.services.Mother.MotherService;
import com.KRM3D.adultfamilyservice.services.Mother.dtos.CreatedMotherDto;
import com.KRM3D.adultfamilyservice.services.Mother.dtos.UpdatedMotherDto;
import com.KRM3D.adultfamilyservice.services.Mother.rules.MotherBusinessRules;
import com.KRM3D.adultfamilyservice.services.Mother.streams.AdultMotherPublishChannel;
import org.modelmapper.ModelMapper;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.cloud.stream.annotation.EnableBinding;
import org.springframework.messaging.support.MessageBuilder;
import org.springframework.stereotype.Service;

@Service
@EnableBinding(AdultMotherPublishChannel.class)
public class MotherServiceImpl implements MotherService {
    private MotherRepository motherRepository;
    private ModelMapper modelMapper;

    private AdultMotherPublishChannel adultMotherPublishChannel;
    private MotherBusinessRules motherBusinessRules;

    @Autowired
    public MotherServiceImpl(MotherRepository motherRepository, ModelMapper modelMapper, AdultMotherPublishChannel adultMotherPublishChannel, MotherBusinessRules motherBusinessRules) {
        this.motherRepository = motherRepository;
        this.modelMapper = modelMapper;
        this.adultMotherPublishChannel = adultMotherPublishChannel;
        this.motherBusinessRules = motherBusinessRules;
    }

    @Override
    public CreatedMotherDto add(CreatedMotherDto createdMotherDto) {
        var mappedResult = this.modelMapper.map(createdMotherDto, Mother.class);
        this.motherBusinessRules.SetToUpper(mappedResult);
        this.motherBusinessRules.SetTrim(mappedResult);
        this.motherRepository.save(mappedResult);
        this.adultMotherPublishChannel.createOutputChannel().send(MessageBuilder.withPayload(mappedResult).build());
        return  createdMotherDto;
    }

    @Override
    public UpdatedMotherDto update(UpdatedMotherDto updatedMotherDto) {
        var mappedResult = this.modelMapper.map(updatedMotherDto, Mother.class);
        this.motherBusinessRules.SetToUpper(mappedResult);
        this.motherBusinessRules.SetTrim(mappedResult);
        this.motherRepository.save(mappedResult);
        this.adultMotherPublishChannel.updateOutputChannel().send(MessageBuilder.withPayload(mappedResult).build());
        return  updatedMotherDto;
    }

    @Override
    public String delete(String id) {
      var getId = this.motherRepository.findById(id).get();
      this.motherRepository.delete(getId);
      this.adultMotherPublishChannel.deleteOutputChannel().send(MessageBuilder.withPayload(getId).build());
      return id;
    }
}
