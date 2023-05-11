package com.krm3d.educationStatus.service.commands.impl;

import com.krm3d.educationStatus.dto.CreatedEducationStatusDto;
import com.krm3d.educationStatus.dto.DeletedEducationStatusDto;
import com.krm3d.educationStatus.dto.UpdatedEducationStatusDto;
import com.krm3d.educationStatus.entity.EducationStatus;
import com.krm3d.educationStatus.repository.EducationStatusRepository;
import com.krm3d.educationStatus.service.commands.EducationStatusCommandService;
import com.krm3d.educationStatus.service.streams.EducationStatusPublishChannel;
import org.modelmapper.ModelMapper;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.cloud.stream.annotation.EnableBinding;
import org.springframework.messaging.support.MessageBuilder;
import org.springframework.stereotype.Service;

@Service
@EnableBinding(EducationStatusPublishChannel.class)
public class EducationStatusCommandServiceImpl implements EducationStatusCommandService {
    private EducationStatusRepository educationStatusRepository;
    private ModelMapper modelMapper;
    private EducationStatusPublishChannel educationStatusPublishChannel;

    @Autowired
    public EducationStatusCommandServiceImpl(EducationStatusRepository educationStatusRepository, ModelMapper modelMapper, EducationStatusPublishChannel educationStatusPublishChannel) {
        this.educationStatusRepository = educationStatusRepository;
        this.modelMapper = modelMapper;
        this.educationStatusPublishChannel = educationStatusPublishChannel;
    }


    @Override
    public CreatedEducationStatusDto createEducationStatus(CreatedEducationStatusDto createdEducationStatusDto) {
       var educationStatus = modelMapper.map(createdEducationStatusDto,EducationStatus.class);
       this.educationStatusRepository.save(educationStatus);
    var mp =    this.educationStatusPublishChannel.createOutputChannel().send(MessageBuilder.withPayload(educationStatus).build());
    System.out.println(mp);
       var result = modelMapper.map(educationStatus, CreatedEducationStatusDto.class);
       return  result;
    }

    @Override
    public UpdatedEducationStatusDto updateEducationStatus(UpdatedEducationStatusDto educationStatus) {
        var mappedEducationStatus = modelMapper.map(educationStatus,EducationStatus.class);
        this.educationStatusRepository.save(mappedEducationStatus);
        this.educationStatusPublishChannel.updateOutputChannel().send(MessageBuilder.withPayload(mappedEducationStatus).build());
        var result = modelMapper.map(mappedEducationStatus, UpdatedEducationStatusDto.class);
        return result;
    }

    @Override
    public DeletedEducationStatusDto deleteEducationStatus(String id) {
        var getId = this.educationStatusRepository.findById(id).get();
        this.educationStatusRepository.delete(getId);
        this.educationStatusPublishChannel.deleteOutputChannel().send(MessageBuilder.withPayload(getId).build());
        var result = modelMapper.map(getId,DeletedEducationStatusDto.class);
        return result;
    }

}
