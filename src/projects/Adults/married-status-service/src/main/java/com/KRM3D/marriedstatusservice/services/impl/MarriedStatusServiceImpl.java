package com.KRM3D.marriedstatusservice.services.impl;

import com.KRM3D.marriedstatusservice.entities.MarriedStatus;
import com.KRM3D.marriedstatusservice.repositories.MarriedStatusRepository;
import com.KRM3D.marriedstatusservice.services.MarriedStatusService;
import com.KRM3D.marriedstatusservice.services.dtos.CreatedMarriedStatusDto;
import com.KRM3D.marriedstatusservice.services.dtos.UpdatedMarriedStatusDto;
import com.KRM3D.marriedstatusservice.services.rules.MarriedStatusBusinessRules;
import com.KRM3D.marriedstatusservice.services.streams.MarriedStatusPublishChannel;
import org.modelmapper.ModelMapper;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.cloud.stream.annotation.EnableBinding;
import org.springframework.messaging.support.MessageBuilder;
import org.springframework.stereotype.Service;

@Service
@EnableBinding(MarriedStatusPublishChannel.class)
public class MarriedStatusServiceImpl implements MarriedStatusService {

    private MarriedStatusRepository marriedStatusRepository;
    private ModelMapper modelMapper;
    private MarriedStatusBusinessRules marriedStatusBusinessRules;
    private MarriedStatusPublishChannel marriedStatusPublishChannel;

    @Autowired
    public MarriedStatusServiceImpl(MarriedStatusRepository marriedStatusRepository, ModelMapper modelMapper, MarriedStatusBusinessRules marriedStatusBusinessRules, MarriedStatusPublishChannel marriedStatusPublishChannel) {
        this.marriedStatusRepository = marriedStatusRepository;
        this.modelMapper = modelMapper;
        this.marriedStatusBusinessRules = marriedStatusBusinessRules;
        this.marriedStatusPublishChannel = marriedStatusPublishChannel;
    }

    @Override
    public CreatedMarriedStatusDto add(CreatedMarriedStatusDto createdMarriedStatusDto) {
        var mappedResult = this.modelMapper.map(createdMarriedStatusDto, MarriedStatus.class);
        this.marriedStatusBusinessRules.SetToUpper(mappedResult);
        this.marriedStatusBusinessRules.SetTrim(mappedResult);
        this.marriedStatusRepository.save(mappedResult);
        this.marriedStatusPublishChannel.createOutputChannel().send(MessageBuilder.withPayload(mappedResult).build());
        return createdMarriedStatusDto;
    }

    @Override
    public UpdatedMarriedStatusDto update(UpdatedMarriedStatusDto updatedMarriedStatusDto) {
        var mappedResult = this.modelMapper.map(updatedMarriedStatusDto, MarriedStatus.class);
        this.marriedStatusBusinessRules.SetToUpper(mappedResult);
        this.marriedStatusBusinessRules.SetTrim(mappedResult);
        this.marriedStatusRepository.save(mappedResult);
        this.marriedStatusPublishChannel.updateOutputChannel().send(MessageBuilder.withPayload(mappedResult).build());
        return updatedMarriedStatusDto;
    }

    @Override
    public String delete(String id) {
        var getId = this.marriedStatusRepository.findById(id).get();
        this.marriedStatusRepository.delete(getId);
        this.marriedStatusPublishChannel.deleteOutputChannel().send(MessageBuilder.withPayload(getId).build());
        return id;

    }
}
