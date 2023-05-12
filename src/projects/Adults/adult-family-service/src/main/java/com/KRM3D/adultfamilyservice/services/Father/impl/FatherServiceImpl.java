package com.KRM3D.adultfamilyservice.services.Father.impl;

import com.KRM3D.adultfamilyservice.entities.Father;
import com.KRM3D.adultfamilyservice.repositories.FatherRepository;
import com.KRM3D.adultfamilyservice.services.Father.FatherService;
import com.KRM3D.adultfamilyservice.services.Father.dtos.CreatedFatherDto;
import com.KRM3D.adultfamilyservice.services.Father.dtos.DeletedFatherDto;
import com.KRM3D.adultfamilyservice.services.Father.dtos.UpdatedFatherDto;
import com.KRM3D.adultfamilyservice.services.Father.rules.FatherBusinessRules;
import com.KRM3D.adultfamilyservice.services.Father.streams.AdultFatherPublishChannel;
import org.modelmapper.ModelMapper;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.cloud.stream.annotation.EnableBinding;
import org.springframework.messaging.support.MessageBuilder;
import org.springframework.stereotype.Service;

@Service
@EnableBinding(AdultFatherPublishChannel.class)
public class FatherServiceImpl implements FatherService {

    private FatherRepository fatherRepository;
    private ModelMapper modelMapper;
    private AdultFatherPublishChannel adultFatherPublishChannel;
    private FatherBusinessRules fatherBusinessRules;
    @Autowired
    public FatherServiceImpl(FatherRepository fatherRepository, ModelMapper modelMapper, AdultFatherPublishChannel adultFatherPublishChannel, FatherBusinessRules fatherBusinessRules) {
        this.fatherRepository = fatherRepository;
        this.modelMapper = modelMapper;
        this.adultFatherPublishChannel = adultFatherPublishChannel;
        this.fatherBusinessRules = fatherBusinessRules;
    }


    @Override
    public CreatedFatherDto add(CreatedFatherDto createdFatherDto) {
        var mappedResult = this.modelMapper.map(createdFatherDto, Father.class);
        this.fatherBusinessRules.SetToUpper(mappedResult);
        this.fatherBusinessRules.SetTrim(mappedResult);
        this.fatherRepository.save(mappedResult);
        this.adultFatherPublishChannel.createOutputChannel().send(MessageBuilder.withPayload(mappedResult).build());
        return  createdFatherDto;

    }

    @Override
    public UpdatedFatherDto update(UpdatedFatherDto updatedFatherDto) {
        var mappedResult = this.modelMapper.map(updatedFatherDto, Father.class);
        this.fatherBusinessRules.SetToUpper(mappedResult);
        this.fatherBusinessRules.SetTrim(mappedResult);
        this.fatherRepository.save(mappedResult);
        this.adultFatherPublishChannel.updateOutputChannel().send(MessageBuilder.withPayload(mappedResult).build());
        return  updatedFatherDto;
    }

    @Override
    public String delete(String id) {
        var getId = this.fatherRepository.findById(id).get();
        this.fatherRepository.delete(getId);
        this.adultFatherPublishChannel.deleteOutputChannel().send(MessageBuilder.withPayload(getId).build());
      return id;
    }
}
