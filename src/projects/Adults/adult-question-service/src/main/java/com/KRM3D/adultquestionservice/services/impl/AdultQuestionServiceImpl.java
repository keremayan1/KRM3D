package com.KRM3D.adultquestionservice.services.impl;

import com.KRM3D.adultquestionservice.entities.AdultQuestion;
import com.KRM3D.adultquestionservice.repositories.AdultQuestionRepository;
import com.KRM3D.adultquestionservice.services.AdultQuestionService;
import com.KRM3D.adultquestionservice.services.dtos.CreatedAdultQuestionDto;
import com.KRM3D.adultquestionservice.services.dtos.DeletedAdultQuestionDto;
import com.KRM3D.adultquestionservice.services.dtos.UpdatedAdultQuestionDto;
import com.KRM3D.adultquestionservice.services.rules.AdultQuestionRules;
import org.modelmapper.ModelMapper;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class AdultQuestionServiceImpl implements AdultQuestionService {
    private AdultQuestionRepository adultQuestionRepository;
    private ModelMapper modelMapper;
    private AdultQuestionRules adultQuestionRules;
    @Autowired
    public AdultQuestionServiceImpl(AdultQuestionRepository adultQuestionRepository, ModelMapper modelMapper, AdultQuestionRules adultQuestionRules) {
        this.adultQuestionRepository = adultQuestionRepository;
        this.modelMapper = modelMapper;
        this.adultQuestionRules = adultQuestionRules;
    }

    @Override
    public CreatedAdultQuestionDto add(CreatedAdultQuestionDto adultQuestion) {
        var mappedAdultQuestions = this.modelMapper.map(adultQuestion, AdultQuestion.class);
        this.adultQuestionRules.DoToUpper(mappedAdultQuestions);
        this.adultQuestionRules.DoTrim(mappedAdultQuestions);
        this.adultQuestionRepository.save(mappedAdultQuestions);
        return  adultQuestion;
    }

    @Override
    public UpdatedAdultQuestionDto update(UpdatedAdultQuestionDto adultQuestion) {
        var mappedAdultQuestions = this.modelMapper.map(adultQuestion, AdultQuestion.class);
        this.adultQuestionRules.DoToUpper(mappedAdultQuestions);
        this.adultQuestionRules.DoTrim(mappedAdultQuestions);
        this.adultQuestionRepository.save(mappedAdultQuestions);
        return  adultQuestion;
    }

    @Override
    public DeletedAdultQuestionDto delete(String id) {
        var getId = this.adultQuestionRepository.findById(id).get();
        this.adultQuestionRepository.delete(getId);
        var result = this.modelMapper.map(getId, DeletedAdultQuestionDto.class);
        return result;
    }

    @Override
    public List<AdultQuestion> getAll() {
        return  this.adultQuestionRepository.findAll();
    }
}
