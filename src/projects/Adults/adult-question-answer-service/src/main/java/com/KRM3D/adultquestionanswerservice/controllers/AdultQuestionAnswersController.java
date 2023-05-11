package com.KRM3D.adultquestionanswerservice.controllers;

import com.KRM3D.adultquestionanswerservice.entities.AdultQuestionAnswer;
import com.KRM3D.adultquestionanswerservice.services.AdultQuestionAnswerService;
import com.KRM3D.adultquestionanswerservice.services.dtos.CreatedAdultQuestionAnswerDto;
import com.KRM3D.adultquestionanswerservice.services.dtos.DeletedAdultQuestionAnswerDto;
import com.KRM3D.adultquestionanswerservice.services.dtos.UpdatedAdultQuestionAnswerDto;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/adultquestionanswer/")
public class AdultQuestionAnswersController {
    private AdultQuestionAnswerService adultQuestionAnswerService;
    @Autowired
    public AdultQuestionAnswersController(AdultQuestionAnswerService adultQuestionAnswerService) {
        this.adultQuestionAnswerService = adultQuestionAnswerService;
    }
    @PostMapping(value = "add")
    public ResponseEntity<List<CreatedAdultQuestionAnswerDto>> add(@RequestBody List<CreatedAdultQuestionAnswerDto> adultQuestionAnswer){
        var result = this.adultQuestionAnswerService.addAll(adultQuestionAnswer);
        return  ResponseEntity.ok(result);
    }
    @PutMapping(value = "update")
    public ResponseEntity<UpdatedAdultQuestionAnswerDto> add(@RequestBody UpdatedAdultQuestionAnswerDto adultQuestionAnswer){
        var result = this.adultQuestionAnswerService.update(adultQuestionAnswer);
        return  ResponseEntity.ok(result);
    }
    @GetMapping(value = "getall")
    public ResponseEntity<List<AdultQuestionAnswer>> add(){
        var result = this.adultQuestionAnswerService.getAll();
        return  ResponseEntity.ok(result);
    }
    @DeleteMapping(value = "delete/{id}")
    @ResponseBody
    public ResponseEntity<DeletedAdultQuestionAnswerDto> add(@PathVariable String id){
        var result = this.adultQuestionAnswerService.delete(id);
        return  ResponseEntity.ok(result);
    }
}
