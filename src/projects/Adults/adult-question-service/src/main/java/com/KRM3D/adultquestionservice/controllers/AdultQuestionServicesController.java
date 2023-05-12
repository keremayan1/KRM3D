package com.KRM3D.adultquestionservice.controllers;

import com.KRM3D.adultquestionservice.entities.AdultQuestion;
import com.KRM3D.adultquestionservice.services.AdultQuestionService;
import com.KRM3D.adultquestionservice.services.dtos.CreatedAdultQuestionDto;
import com.KRM3D.adultquestionservice.services.dtos.DeletedAdultQuestionDto;
import com.KRM3D.adultquestionservice.services.dtos.UpdatedAdultQuestionDto;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.mongodb.core.query.Update;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.List;

@RestController
@RequestMapping("/api/adultquestion/")
public class AdultQuestionServicesController {
    private AdultQuestionService adultQuestionService;
    @Autowired
    public AdultQuestionServicesController(AdultQuestionService adultQuestionService) {
        this.adultQuestionService = adultQuestionService;
    }
    @PostMapping(value = "add")
    public ResponseEntity<CreatedAdultQuestionDto> add(@RequestBody @Valid CreatedAdultQuestionDto createdAdultQuestionDto){
        var result = this.adultQuestionService.add(createdAdultQuestionDto);
        return  ResponseEntity.ok(result);
    }
    @DeleteMapping(value = "delete/{id}")
    public ResponseEntity<DeletedAdultQuestionDto> add(@PathVariable String id){
        var result = this.adultQuestionService.delete(id);
        return  ResponseEntity.ok(result);
    }
    @PutMapping(value = "update")
    public ResponseEntity<UpdatedAdultQuestionDto> add(@RequestBody @Valid UpdatedAdultQuestionDto updatedAdultQuestionDto){
        var result = this.adultQuestionService.update(updatedAdultQuestionDto);
        return  ResponseEntity.ok(result);
    }
    @GetMapping(value = "getall")
    public ResponseEntity<List<AdultQuestion>> add(){
        var result = this.adultQuestionService.getAll();
        return  ResponseEntity.ok(result);
    }
}
