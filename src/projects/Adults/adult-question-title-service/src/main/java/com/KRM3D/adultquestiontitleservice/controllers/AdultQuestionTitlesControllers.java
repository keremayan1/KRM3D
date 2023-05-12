package com.KRM3D.adultquestiontitleservice.controllers;

import com.KRM3D.adultquestiontitleservice.services.AdultQuestionTitleService;
import com.KRM3D.adultquestiontitleservice.services.dto.CreatedAdultQuestionTitleDto;
import com.KRM3D.adultquestiontitleservice.services.dto.DeletedAdultQuestionTitleDto;
import com.KRM3D.adultquestiontitleservice.services.dto.UpdatedAdultQuestionTitleDto;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;

@RestController
@RequestMapping("api/adultquestiontitle/")
public class AdultQuestionTitlesControllers {
    private AdultQuestionTitleService adultQuestionTitleService;

    public AdultQuestionTitlesControllers(AdultQuestionTitleService adultQuestionTitleService) {
        this.adultQuestionTitleService = adultQuestionTitleService;
    }
    @PostMapping(value = "add")
    public ResponseEntity<CreatedAdultQuestionTitleDto> add(@RequestBody @Valid CreatedAdultQuestionTitleDto adultQuestionTitleDto){
        var result = this.adultQuestionTitleService.add(adultQuestionTitleDto);
        return  ResponseEntity.ok(result);
    }
    @PutMapping(value = "update")
    public ResponseEntity<UpdatedAdultQuestionTitleDto> update(@RequestBody @Valid UpdatedAdultQuestionTitleDto adultQuestionTitleDto){
        var result = this.adultQuestionTitleService.update(adultQuestionTitleDto);
        return  ResponseEntity.ok(result);
    }
    @DeleteMapping(value = "delete/{id}")
    @ResponseBody
    public ResponseEntity<DeletedAdultQuestionTitleDto> add(@PathVariable String id){
        var result = this.adultQuestionTitleService.delete(id);
        return  ResponseEntity.ok(result);
    }
}
