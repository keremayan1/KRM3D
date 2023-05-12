package com.KRM3D.adultfamilyservice.controllers;

import com.KRM3D.adultfamilyservice.services.Father.FatherService;
import com.KRM3D.adultfamilyservice.services.Father.dtos.CreatedFatherDto;
import com.KRM3D.adultfamilyservice.services.Father.dtos.DeletedFatherDto;
import com.KRM3D.adultfamilyservice.services.Father.dtos.UpdatedFatherDto;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;

@RestController
@RequestMapping("/api/adultfamily/father/")
public class FathersController {
    private FatherService fatherService;

    @Autowired
    public FathersController(FatherService fatherService) {
        this.fatherService = fatherService;
    }
    @PostMapping(value = "add")
    public ResponseEntity<CreatedFatherDto> add(@RequestBody @Valid CreatedFatherDto father){
        var result = this.fatherService.add(father);
        return  ResponseEntity.ok(result);
    }
    @PutMapping (value = "update")
    public ResponseEntity<UpdatedFatherDto> update(@RequestBody @Valid UpdatedFatherDto father){
        var result = this.fatherService.update(father);
        return  ResponseEntity.ok(result);
    }

    @DeleteMapping (value = "delete/{id}")
    @ResponseBody
    public ResponseEntity<String> delete(@PathVariable String id){
        var result = this.fatherService.delete(id);
        return  ResponseEntity.ok(result);
    }
}
