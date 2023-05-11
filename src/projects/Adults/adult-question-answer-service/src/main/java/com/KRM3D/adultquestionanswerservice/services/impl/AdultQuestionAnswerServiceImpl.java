package com.KRM3D.adultquestionanswerservice.services.impl;

import com.KRM3D.adultquestionanswerservice.entities.AdultQuestionAnswer;
import com.KRM3D.adultquestionanswerservice.repositories.AdultQuestionAnswerRepository;
import com.KRM3D.adultquestionanswerservice.services.AdultQuestionAnswerService;
import com.KRM3D.adultquestionanswerservice.services.dtos.CreatedAdultQuestionAnswerDto;
import com.KRM3D.adultquestionanswerservice.services.dtos.DeletedAdultQuestionAnswerDto;
import com.KRM3D.adultquestionanswerservice.services.dtos.UpdatedAdultQuestionAnswerDto;
import com.KRM3D.adultquestionanswerservice.services.rules.AdultQuestionAnswerRules;
import org.modelmapper.ModelMapper;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class AdultQuestionAnswerServiceImpl implements AdultQuestionAnswerService {
    private AdultQuestionAnswerRepository adultQuestionAnswerRepository;
    private ModelMapper modelMapper;
    private AdultQuestionAnswerRules adultQuestionAnswerRules;

    @Autowired
    public AdultQuestionAnswerServiceImpl(AdultQuestionAnswerRepository adultQuestionAnswerRepository, ModelMapper modelMapper, AdultQuestionAnswerRules adultQuestionAnswerRules) {
        this.adultQuestionAnswerRepository = adultQuestionAnswerRepository;
        this.modelMapper = modelMapper;
        this.adultQuestionAnswerRules = adultQuestionAnswerRules;
    }

    @Override
    public List<CreatedAdultQuestionAnswerDto> addAll(List<CreatedAdultQuestionAnswerDto> createdAdultQuestionAnswer) {
        for (var createdAdultQuestionAnswers:createdAdultQuestionAnswer) {
            var mappedAdultQuestionAnswer = this.modelMapper.map(createdAdultQuestionAnswers,AdultQuestionAnswer.class);
            this.adultQuestionAnswerRules.DoToUpper(mappedAdultQuestionAnswer);
            this.adultQuestionAnswerRules.DoToTrim(mappedAdultQuestionAnswer);
            this.adultQuestionAnswerRepository.save(mappedAdultQuestionAnswer);

        }
        return createdAdultQuestionAnswer;


    }

    @Override
    public UpdatedAdultQuestionAnswerDto update(UpdatedAdultQuestionAnswerDto updatedAdultQuestionAnswerDto) {
        var mappedAdultQuestionAnswer = this.modelMapper.map(updatedAdultQuestionAnswerDto,AdultQuestionAnswer.class);
        this.adultQuestionAnswerRules.DoToUpper(mappedAdultQuestionAnswer);
        this.adultQuestionAnswerRules.DoToTrim(mappedAdultQuestionAnswer);
        this.adultQuestionAnswerRepository.save(mappedAdultQuestionAnswer);
        return  updatedAdultQuestionAnswerDto;
    }

    @Override
    public DeletedAdultQuestionAnswerDto delete(String id) {
      var getId = this.adultQuestionAnswerRepository.findById(id).get();
      this.adultQuestionAnswerRepository.delete(getId);
      var result = this.modelMapper.map(getId,DeletedAdultQuestionAnswerDto.class);
      return  result;
    }

    @Override
    public List<AdultQuestionAnswer> getAll() {
        return this.adultQuestionAnswerRepository.findAll();
    }
}
