package com.KRM3D.marriedstatusservice.controllers;

import com.KRM3D.marriedstatusservice.services.MarriedStatusService;
import com.KRM3D.marriedstatusservice.services.dtos.CreatedMarriedStatusDto;
import com.KRM3D.marriedstatusservice.services.dtos.UpdatedMarriedStatusDto;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;

@RestController
@RequestMapping("/api/marriedstatus/")
public class MarriedStatusesController {

    private MarriedStatusService marriedStatusService;

    @Autowired
    public MarriedStatusesController(MarriedStatusService marriedStatusService) {
        this.marriedStatusService = marriedStatusService;
    }
    @PostMapping(value = "add")
    public ResponseEntity<CreatedMarriedStatusDto> add(@RequestBody @Valid CreatedMarriedStatusDto createdMarriedStatusDto){
        var result = this.marriedStatusService.add(createdMarriedStatusDto);
        return  ResponseEntity.ok(result);
    }
    @PutMapping(value = "update")
    public ResponseEntity<UpdatedMarriedStatusDto> update(@RequestBody @Valid UpdatedMarriedStatusDto updatedMarriedStatusDto){
        var result = this.marriedStatusService.update(updatedMarriedStatusDto);
        return  ResponseEntity.ok(result);
    }

    @DeleteMapping (value = "delete/{id}")
    @ResponseBody
    public ResponseEntity<String> delete(@PathVariable String id){
        var result = this.marriedStatusService.delete(id);
        return  ResponseEntity.ok(result);
    }
}
