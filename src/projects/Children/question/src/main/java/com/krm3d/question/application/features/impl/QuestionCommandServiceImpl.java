package com.krm3d.question.application.features.impl;


import com.krm3d.question.application.features.QuestionCommandService;
import com.krm3d.question.application.features.dtos.CreatedQuestionDto;
import com.krm3d.question.application.features.dtos.DeletedQuestionDto;
import com.krm3d.question.application.features.dtos.UpdatedQuestionDto;

import com.krm3d.question.application.features.streams.QuestionPublishChannel;
import com.krm3d.question.domain.entities.Question;

import com.krm3d.question.persistance.repositories.QuestionRepository;
import org.modelmapper.ModelMapper;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.cloud.stream.annotation.EnableBinding;
import org.springframework.messaging.support.MessageBuilder;
import org.springframework.stereotype.Service;

@Service
@EnableBinding(QuestionPublishChannel.class)
public class QuestionCommandServiceImpl  implements QuestionCommandService {
    private QuestionRepository questionRepository;
    private ModelMapper modelMapper;
    private QuestionPublishChannel questionPublishChannel;
    @Autowired
    public QuestionCommandServiceImpl(QuestionRepository questionRepository, ModelMapper modelMapper, QuestionPublishChannel questionPublishChannel) {
        this.questionRepository = questionRepository;
        this.modelMapper = modelMapper;
        this.questionPublishChannel = questionPublishChannel;
    }

    @Override
    public CreatedQuestionDto add(CreatedQuestionDto createdQuestionDto) {
        var mappedQuestion= this.modelMapper.map(createdQuestionDto, Question.class);
        this.questionRepository.save(mappedQuestion);
        System.out.println(this.questionPublishChannel.createOutputChannel().send(MessageBuilder.withPayload(mappedQuestion).build()));
        return  createdQuestionDto;
    }

    @Override
    public DeletedQuestionDto delete(String id) {
       var getId = this.questionRepository.findById(id).get();
       this.questionRepository.delete(getId);
       this.questionPublishChannel.deleteOutputChannel().send(MessageBuilder.withPayload(getId).build());
       var result = this.modelMapper.map(getId,DeletedQuestionDto.class);
       return  result;
    }

    @Override
    public UpdatedQuestionDto update(UpdatedQuestionDto updatedQuestionDto) {
       var mappedQuestion = this.modelMapper.map(updatedQuestionDto,Question.class);
       this.questionRepository.save(mappedQuestion);
       this.questionPublishChannel.updateOutputChannel().send(MessageBuilder.withPayload(mappedQuestion).build());
       return updatedQuestionDto;
    }
}
