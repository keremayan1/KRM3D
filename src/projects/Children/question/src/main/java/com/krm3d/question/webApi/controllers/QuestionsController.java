package com.krm3d.question.webApi.controllers;

import com.krm3d.question.application.features.QuestionCommandService;
import com.krm3d.question.application.features.dtos.CreatedQuestionDto;
import com.krm3d.question.application.features.dtos.DeletedQuestionDto;
import com.krm3d.question.application.features.dtos.UpdatedQuestionDto;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("/api/question/")
public class QuestionsController {
    private QuestionCommandService questionCommandService;

    @Autowired
    public QuestionsController(QuestionCommandService questionCommandService) {
        this.questionCommandService = questionCommandService;
    }
    @PostMapping(value = "add")
    public ResponseEntity<CreatedQuestionDto> add(@RequestBody CreatedQuestionDto createdQuestionDto){
        var result = this.questionCommandService.add(createdQuestionDto);
        return  ResponseEntity.ok(result);
    }
    @PutMapping(value = "update")
    public ResponseEntity<UpdatedQuestionDto> update(@RequestBody UpdatedQuestionDto updatedQuestionDto){
        var result = this.questionCommandService.update(updatedQuestionDto);
        return  ResponseEntity.ok(result);
    }
    @DeleteMapping(value = "delete/{id}")
    @ResponseBody
    public ResponseEntity<DeletedQuestionDto> delete(@PathVariable String id){
        var result = this.questionCommandService.delete(id);
        return  ResponseEntity.ok(result);
    }
}
