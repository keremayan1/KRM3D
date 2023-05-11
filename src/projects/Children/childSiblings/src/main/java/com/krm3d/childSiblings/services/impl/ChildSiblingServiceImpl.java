package com.krm3d.childSiblings.services.impl;

import com.krm3d.childSiblings.dtos.CreatedChildSiblingsDto;
import com.krm3d.childSiblings.dtos.DeletedChildSiblingsDto;
import com.krm3d.childSiblings.dtos.UpdatedChildSiblingsDto;
import com.krm3d.childSiblings.entities.ChildSiblings;
import com.krm3d.childSiblings.repositories.ChildSiblingsRepository;
import com.krm3d.childSiblings.rules.ChildSiblingsBusinessRules;
import com.krm3d.childSiblings.services.ChildSiblingsService;
import com.krm3d.childSiblings.services.streams.ChildSiblingsPublishChannel;
import org.modelmapper.ModelMapper;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.cloud.stream.annotation.EnableBinding;
import org.springframework.messaging.Message;
import org.springframework.messaging.support.MessageBuilder;
import org.springframework.stereotype.Service;

import java.util.Arrays;
import java.util.List;

@Service
@EnableBinding(ChildSiblingsPublishChannel.class)
public class ChildSiblingServiceImpl implements ChildSiblingsService {
    private ChildSiblingsRepository childSiblingsRepository;
    private ChildSiblingsBusinessRules childSiblingsBusinessRules;
    private ModelMapper mapper;
    private ChildSiblingsPublishChannel childSiblingsPublishChannel;
    @Autowired
    public ChildSiblingServiceImpl(ChildSiblingsRepository childSiblingsRepository, ChildSiblingsBusinessRules childSiblingsBusinessRules, ModelMapper mapper, ChildSiblingsPublishChannel childSiblingsPublishChannel) {
        this.childSiblingsRepository = childSiblingsRepository;
        this.childSiblingsBusinessRules = childSiblingsBusinessRules;
        this.mapper = mapper;
        this.childSiblingsPublishChannel = childSiblingsPublishChannel;
    }

    @Override
    public CreatedChildSiblingsDto add(CreatedChildSiblingsDto createdChildSiblingsDto) {
        var mappedChildrenSiblings = this.mapper.map(createdChildSiblingsDto, ChildSiblings.class);
        this.childSiblingsRepository.save(mappedChildrenSiblings);
        var result = this.mapper.map(mappedChildrenSiblings, CreatedChildSiblingsDto.class);
        return result;
    }

    @Override
    public List<CreatedChildSiblingsDto> addAll(List<CreatedChildSiblingsDto> createdChildSiblingsDto)throws Exception {
        var ch = Arrays.asList(mapper.map(createdChildSiblingsDto, ChildSiblings[].class));
        this.childSiblingsRepository.saveAll(ch);
        return createdChildSiblingsDto;
    }

    @Override
    public List<CreatedChildSiblingsDto> addAll2(List<CreatedChildSiblingsDto> createdChildSiblingsDto) throws Exception {
        for (var createdChildSiblings: createdChildSiblingsDto) {
            var  childSiblings= mapper.map(createdChildSiblings, ChildSiblings.class);
            this.childSiblingsBusinessRules.ToUpper(childSiblings);
            this.childSiblingsBusinessRules.Trim(childSiblings);
            this.childSiblingsRepository.save(childSiblings);
            this.childSiblingsPublishChannel.createOutputChannel().send(MessageBuilder.withPayload(childSiblings).build());
        }
        System.out.println("Islem Basarılı");
        return  createdChildSiblingsDto;
    }

    @Override
    public UpdatedChildSiblingsDto update(UpdatedChildSiblingsDto updatedChildSiblingsDto) {
        var mappedChildrenSiblings = this.mapper.map(updatedChildSiblingsDto, ChildSiblings.class);
        this.childSiblingsRepository.save(mappedChildrenSiblings);
        this.childSiblingsPublishChannel.updateOutputChannel().send(MessageBuilder.withPayload(mappedChildrenSiblings).build());
        return updatedChildSiblingsDto;
    }

    @Override
    public DeletedChildSiblingsDto delete(DeletedChildSiblingsDto deletedChildSiblingsDto) {
        var mappedId = this.childSiblingsRepository.findById(deletedChildSiblingsDto.getId()).get();
        this.childSiblingsRepository.delete(mappedId);
        this.childSiblingsPublishChannel.deleteOutputChannel().send(MessageBuilder.withPayload(mappedId).build());
        return deletedChildSiblingsDto;
    }

    @Override
    public DeletedChildSiblingsDto delete2(String childSiblingsId) {
        var getId = this.childSiblingsRepository.findById(childSiblingsId).get();
        this.childSiblingsRepository.delete(getId);
        this.childSiblingsPublishChannel.deleteOutputChannel().send(MessageBuilder.withPayload(getId).build());
        var mappedChildSiblings = this.mapper.map(getId, DeletedChildSiblingsDto.class);
        return mappedChildSiblings;
    }
}
