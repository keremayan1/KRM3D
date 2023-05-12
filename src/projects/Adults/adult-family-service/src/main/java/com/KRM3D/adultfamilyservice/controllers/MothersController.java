package com.KRM3D.adultfamilyservice.controllers;

import com.KRM3D.adultfamilyservice.services.Father.dtos.CreatedFatherDto;
import com.KRM3D.adultfamilyservice.services.Father.dtos.UpdatedFatherDto;
import com.KRM3D.adultfamilyservice.services.Mother.MotherService;
import com.KRM3D.adultfamilyservice.services.Mother.dtos.CreatedMotherDto;
import com.KRM3D.adultfamilyservice.services.Mother.dtos.UpdatedMotherDto;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;

@RestController
@RequestMapping("/api/adultfamily/mother/")
public class MothersController {
    private MotherService motherService;

    @Autowired
    public MothersController(MotherService motherService) {
        this.motherService = motherService;
    }
    @PostMapping(value = "add")
    public ResponseEntity<CreatedMotherDto> add(@RequestBody @Valid CreatedMotherDto motherDto){
        var result = this.motherService.add(motherDto);
        return  ResponseEntity.ok(result);
    }
    @PutMapping(value = "update")
    public ResponseEntity<UpdatedMotherDto> update(@RequestBody @Valid UpdatedMotherDto motherDto){
        var result = this.motherService.update(motherDto);
        return  ResponseEntity.ok(result);
    }

    @DeleteMapping (value = "delete/{id}")
    @ResponseBody
    public ResponseEntity<String> delete(@PathVariable String id){
        var result = this.motherService.delete(id);
        return  ResponseEntity.ok(result);
    }
}
