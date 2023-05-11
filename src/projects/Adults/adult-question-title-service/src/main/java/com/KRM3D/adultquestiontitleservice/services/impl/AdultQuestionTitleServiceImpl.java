package com.KRM3D.adultquestiontitleservice.services.impl;

import com.KRM3D.adultquestiontitleservice.entities.AdultQuestionTitle;
import com.KRM3D.adultquestiontitleservice.repositories.AdultQuestionTitleRepository;
import com.KRM3D.adultquestiontitleservice.services.AdultQuestionTitleService;
import com.KRM3D.adultquestiontitleservice.services.dto.CreatedAdultQuestionTitleDto;
import com.KRM3D.adultquestiontitleservice.services.dto.DeletedAdultQuestionTitleDto;
import com.KRM3D.adultquestiontitleservice.services.dto.UpdatedAdultQuestionTitleDto;
import com.KRM3D.adultquestiontitleservice.services.rules.AdultQuestionTitleRules;
import org.modelmapper.ModelMapper;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class AdultQuestionTitleServiceImpl implements AdultQuestionTitleService {
    private AdultQuestionTitleRepository adultQuestionTitleRepository;
    private ModelMapper modelMapper;
    private AdultQuestionTitleRules adultQuestionTitleRules;
    @Autowired
    public AdultQuestionTitleServiceImpl(AdultQuestionTitleRepository adultQuestionTitleRepository, ModelMapper modelMapper, AdultQuestionTitleRules adultQuestionTitleRules) {
        this.adultQuestionTitleRepository = adultQuestionTitleRepository;
        this.modelMapper = modelMapper;
        this.adultQuestionTitleRules = adultQuestionTitleRules;
    }
    @Override
    public CreatedAdultQuestionTitleDto add(CreatedAdultQuestionTitleDto adultQuestionTitleDto) {
        var mappedAdultQuestionTitles = this.modelMapper.map(adultQuestionTitleDto, AdultQuestionTitle.class);
        this.adultQuestionTitleRules.DoToUpper(mappedAdultQuestionTitles);
        this.adultQuestionTitleRules.DoTrim(mappedAdultQuestionTitles);
        this.adultQuestionTitleRepository.save(mappedAdultQuestionTitles);
        return adultQuestionTitleDto;
    }

    @Override
    public UpdatedAdultQuestionTitleDto update(UpdatedAdultQuestionTitleDto adultQuestionTitle) {
        var mappedAdultQuestionTitles = this.modelMapper.map(adultQuestionTitle, AdultQuestionTitle.class);
        this.adultQuestionTitleRules.DoToUpper(mappedAdultQuestionTitles);
        this.adultQuestionTitleRules.DoTrim(mappedAdultQuestionTitles);
        this.adultQuestionTitleRepository.save(mappedAdultQuestionTitles);
        return adultQuestionTitle;
    }

    @Override
    public DeletedAdultQuestionTitleDto delete(String id) {
        var getId = this.adultQuestionTitleRepository.findById(id).get();
        this.adultQuestionTitleRepository.delete(getId);
        var result = this.modelMapper.map(getId, DeletedAdultQuestionTitleDto.class);
        return result;
    }
}
