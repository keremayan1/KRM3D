package com.KRM3D.adultservice.services.impl;


import com.KRM3D.adultservice.entities.Adult;

import com.KRM3D.adultservice.repositories.AdultRepository;
import com.KRM3D.adultservice.services.dtos.CreatedAdultDto;
import com.KRM3D.adultservice.services.dtos.DeletedAdultDto;
import com.KRM3D.adultservice.services.dtos.UpdatedAdultDto;
import com.KRM3D.adultservice.services.rules.AdultBusinessRules;
import com.KRM3D.adultservice.services.AdultService;
import com.KRM3D.adultservice.services.streams.AdultPublishChannel;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.cloud.stream.annotation.EnableBinding;
import org.springframework.messaging.support.MessageBuilder;
import org.springframework.stereotype.Service;
import org.modelmapper.ModelMapper;


@Service
@EnableBinding(AdultPublishChannel.class)
public class AdultServiceImpl implements AdultService {

   private AdultRepository adultRepository;
    private AdultBusinessRules adultBusinessRules;
    private ModelMapper modelMapper;
    private AdultPublishChannel adultPublishChannel;

    @Autowired
    public AdultServiceImpl(AdultRepository adultRepository, AdultBusinessRules adultBusinessRules, ModelMapper modelMapper, AdultPublishChannel adultPublishChannel) {
        this.adultRepository = adultRepository;
        this.adultBusinessRules = adultBusinessRules;
        this.modelMapper = modelMapper;
        this.adultPublishChannel = adultPublishChannel;
    }

    @Override
    public CreatedAdultDto add(CreatedAdultDto adult) throws Exception {
        var mappedAdults = this.modelMapper.map(adult, Adult.class);
        this.adultBusinessRules.SetToUpper(mappedAdults);
        this.adultBusinessRules.SetTrim(mappedAdults);
       this.adultBusinessRules.VerifyNationalId(mappedAdults);
       this.adultBusinessRules.CheckIfNationalIdExists(mappedAdults.getNationalId());
        this.adultRepository.save(mappedAdults);
        this.adultPublishChannel.createOutputChannel().send(MessageBuilder.withPayload(mappedAdults).build());
        return adult;
    }

    @Override
    public UpdatedAdultDto update(UpdatedAdultDto adult) throws Exception {
        var mappedAdults = this.modelMapper.map(adult, Adult.class);
        this.adultBusinessRules.SetToUpper(mappedAdults);
        this.adultBusinessRules.SetTrim(mappedAdults);
      //  this.adultBusinessRules.VerifyNationalId(mappedAdults);
        //this.adultBusinessRules.CheckIfNationalIdExists(mappedAdults.getNationalId());
        this.adultRepository.save(mappedAdults);
        this.adultPublishChannel.updateOutputChannel().send(MessageBuilder.withPayload(mappedAdults).build());
        return adult;
    }

    @Override
    public DeletedAdultDto delete(String adultId) {
        var getId = this.adultRepository.findById(adultId).get();
        this.adultRepository.delete(getId);
        this.adultPublishChannel.deleteOutputChannel().send(MessageBuilder.withPayload(getId).build());
        var mappedResult = this.modelMapper.map(getId, DeletedAdultDto.class);
        return mappedResult;
    }
}
