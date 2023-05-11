package com.krm3d.childSiblings.controllers;

import com.krm3d.childSiblings.dtos.CreatedChildSiblingsDto;
import com.krm3d.childSiblings.dtos.DeletedChildSiblingsDto;
import com.krm3d.childSiblings.dtos.UpdatedChildSiblingsDto;
import com.krm3d.childSiblings.services.ChildSiblingsService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/childSiblings/")
public class ChildSiblingsControllers {
    private ChildSiblingsService childSiblingsService;
    @Autowired
    public ChildSiblingsControllers(ChildSiblingsService childSiblingsService) {
        this.childSiblingsService = childSiblingsService;

    }
    @PostMapping(value = "addAll")
    public ResponseEntity<List<CreatedChildSiblingsDto>> add(@RequestBody List<CreatedChildSiblingsDto> createdChildSiblingsDtos) throws  Exception
    {
      var result =  this.childSiblingsService.addAll2(createdChildSiblingsDtos);
        return ResponseEntity.ok(result);
    }
    @PutMapping(value = "update")
    public ResponseEntity<UpdatedChildSiblingsDto> update(@RequestBody UpdatedChildSiblingsDto updatedChildSiblingsDtos) throws  Exception
    {
        var result =  this.childSiblingsService.update(updatedChildSiblingsDtos);
        return ResponseEntity.ok(result);
    }
    @DeleteMapping(value = "delete/{childSiblingsId}")
    @ResponseBody
    public ResponseEntity<DeletedChildSiblingsDto> delete(@PathVariable String childSiblingsId) throws  Exception
    {
        var result =  this.childSiblingsService.delete2(childSiblingsId);
        return ResponseEntity.ok(result);
    }
}
