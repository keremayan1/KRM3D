package com.KRM3D.adultfamilyservice.services.Siblings.impl;

import com.KRM3D.adultfamilyservice.entities.Siblings;
import com.KRM3D.adultfamilyservice.repositories.SiblingsRepository;
import com.KRM3D.adultfamilyservice.services.Siblings.SiblingsService;
import com.KRM3D.adultfamilyservice.services.Siblings.dtos.CreatedSiblingsDto;
import com.KRM3D.adultfamilyservice.services.Siblings.dtos.UpdatedSiblingsDto;
import com.KRM3D.adultfamilyservice.services.Siblings.rules.SiblingsBusinessRules;
import com.KRM3D.adultfamilyservice.services.Siblings.streams.AdultSiblingsPublishChannel;
import org.modelmapper.ModelMapper;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.cloud.stream.annotation.EnableBinding;
import org.springframework.messaging.support.MessageBuilder;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
@EnableBinding(AdultSiblingsPublishChannel.class)
public class SiblingsServiceImpl implements SiblingsService {

    private SiblingsRepository siblingsRepository;
    private ModelMapper modelMapper;
    private SiblingsBusinessRules siblingsBusinessRules;
    private AdultSiblingsPublishChannel adultSiblingsPublishChannel;

    @Autowired
    public SiblingsServiceImpl(SiblingsRepository siblingsRepository, ModelMapper modelMapper, SiblingsBusinessRules siblingsBusinessRules, AdultSiblingsPublishChannel adultSiblingsPublishChannel) {
        this.siblingsRepository = siblingsRepository;
        this.modelMapper = modelMapper;
        this.siblingsBusinessRules = siblingsBusinessRules;
        this.adultSiblingsPublishChannel = adultSiblingsPublishChannel;
    }

    @Override
    public List<CreatedSiblingsDto> add(List<CreatedSiblingsDto> createdSiblingsDto) {
        for (var siblings : createdSiblingsDto) {
            var mappedResult = this.modelMapper.map(siblings, Siblings.class);
            this.siblingsBusinessRules.SetToUpper(mappedResult);
            this.siblingsBusinessRules.SetTrim(mappedResult);
            this.siblingsRepository.save(mappedResult);
            this.adultSiblingsPublishChannel.createOutputChannel().send(MessageBuilder.withPayload(mappedResult).build());
        }
        return createdSiblingsDto;
    }

    @Override
    public UpdatedSiblingsDto update(UpdatedSiblingsDto updatedSiblingsDto) {
        var mappedResult = this.modelMapper.map(updatedSiblingsDto, Siblings.class);
        this.siblingsBusinessRules.SetToUpper(mappedResult);
        this.siblingsBusinessRules.SetTrim(mappedResult);
        this.siblingsRepository.save(mappedResult);
        this.adultSiblingsPublishChannel.updateOutputChannel().send(MessageBuilder.withPayload(mappedResult).build());
        return updatedSiblingsDto;
    }

    @Override
    public String delete(String id) {
        var getId = this.siblingsRepository.findById(id).get();
        this.siblingsRepository.delete(getId);
        this.adultSiblingsPublishChannel.deleteOutputChannel().send(MessageBuilder.withPayload(getId).build());
        return id;
    }
}
