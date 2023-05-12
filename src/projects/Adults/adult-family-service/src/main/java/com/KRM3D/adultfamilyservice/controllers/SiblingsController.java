package com.KRM3D.adultfamilyservice.controllers;

import com.KRM3D.adultfamilyservice.services.Siblings.SiblingsService;
import com.KRM3D.adultfamilyservice.services.Siblings.dtos.CreatedSiblingsDto;
import com.KRM3D.adultfamilyservice.services.Siblings.dtos.UpdatedSiblingsDto;
import com.KRM3D.adultfamilyservice.services.validation.ValidateRequestBodyList;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.List;

@RestController
@RequestMapping("/api/adultfamily/siblings/")
public class SiblingsController {
    private SiblingsService siblingsService;

    @Autowired
    public SiblingsController(SiblingsService siblingsService) {
        this.siblingsService = siblingsService;
    }
    @PostMapping(value = "add")
    public ResponseEntity<List<CreatedSiblingsDto>> add(@RequestBody @Valid ValidateRequestBodyList<CreatedSiblingsDto> adultQuestionAnswer){
        var result= adultQuestionAnswer.getRequestBody();
        var response = this.siblingsService.add(result);
        return  ResponseEntity.ok(response);
    }
    @PutMapping(value = "update")
    public ResponseEntity<UpdatedSiblingsDto> add(@RequestBody UpdatedSiblingsDto adultQuestionAnswer){
        var result = this.siblingsService.update(adultQuestionAnswer);
        return  ResponseEntity.ok(result);
    }

    @DeleteMapping(value = "delete/{id}")
    @ResponseBody
    public ResponseEntity<String> add(@PathVariable String id){
        var result = this.siblingsService.delete(id);
        return  ResponseEntity.ok(result);
    }
}
