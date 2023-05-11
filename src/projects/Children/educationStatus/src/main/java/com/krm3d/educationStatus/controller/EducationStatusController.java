package com.krm3d.educationStatus.controller;

import com.krm3d.educationStatus.dto.CreatedEducationStatusDto;
import com.krm3d.educationStatus.dto.DeletedEducationStatusDto;
import com.krm3d.educationStatus.dto.UpdatedEducationStatusDto;
import com.krm3d.educationStatus.entity.EducationStatus;
import com.krm3d.educationStatus.service.commands.EducationStatusCommandService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("/api/educationStatus/")
public class EducationStatusController {
    private EducationStatusCommandService educationStatusCommandService;

    @Autowired
    public EducationStatusController(EducationStatusCommandService educationStatusCommandService) {
        this.educationStatusCommandService = educationStatusCommandService;
    }
    @PostMapping(value = "add")
    public ResponseEntity<CreatedEducationStatusDto> add(@RequestBody CreatedEducationStatusDto createdEducationStatusDto){
       var result = this.educationStatusCommandService.createEducationStatus(createdEducationStatusDto);
        return  ResponseEntity.ok(result);
    }
    @PutMapping(value = "update")
    public ResponseEntity<UpdatedEducationStatusDto> update(@RequestBody UpdatedEducationStatusDto updatedEducationStatusDto){
        var result = this.educationStatusCommandService.updateEducationStatus(updatedEducationStatusDto);
        return  ResponseEntity.ok(result);
    }
    @DeleteMapping(value = "delete/{id}")
    @ResponseBody
    public ResponseEntity<DeletedEducationStatusDto> update(@PathVariable String id){
        var result = this.educationStatusCommandService.deleteEducationStatus(id);
        return  ResponseEntity.ok(result);
    }

}
