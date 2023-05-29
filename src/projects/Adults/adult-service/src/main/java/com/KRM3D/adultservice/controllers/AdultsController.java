package com.KRM3D.adultservice.controllers;



import com.KRM3D.adultservice.services.AdultService;
import com.KRM3D.adultservice.services.dtos.CreatedAdultDto;
import com.KRM3D.adultservice.services.dtos.DeletedAdultDto;
import com.KRM3D.adultservice.services.dtos.UpdatedAdultDto;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;

@RestController
@RequestMapping("/api/adult/")
public class AdultsController {
    private AdultService adultService;
    @Autowired
    public AdultsController(AdultService adultService) {
        this.adultService = adultService;
    }
    @PostMapping(value = "add")
    public ResponseEntity<CreatedAdultDto> add(@RequestBody @Valid CreatedAdultDto adult) throws Exception {
        var result = this.adultService.add(adult);

        return  ResponseEntity.ok(result);
    }
    @PutMapping(value = "update")
    public ResponseEntity<UpdatedAdultDto> update(@RequestBody @Valid UpdatedAdultDto updatedQuestionDto) throws Exception {
        var result = this.adultService.update(updatedQuestionDto);
        return  ResponseEntity.ok(result);
    }
    @DeleteMapping(value = "delete/{id}")
    @ResponseBody
    public ResponseEntity<DeletedAdultDto> delete(@PathVariable String id){
        var result = this.adultService.delete(id);
        return  ResponseEntity.ok(result);
    }
}
