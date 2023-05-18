package com.KRM3D.childsiblings.controllers;

import com.KRM3D.childsiblings.dtos.CreatedChildSiblingsDto;
import com.KRM3D.childsiblings.dtos.DeletedChildSiblingsDto;
import com.KRM3D.childsiblings.dtos.UpdatedChildSiblingsDto;
import com.KRM3D.childsiblings.services.ChildSiblingsService;
import com.KRM3D.childsiblings.services.validation.ValidateRequestBodyList;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
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
    public ResponseEntity<List<CreatedChildSiblingsDto>> add(@RequestBody @Valid ValidateRequestBodyList<CreatedChildSiblingsDto> createdChildSiblingsDtos) throws Exception {
        var response = createdChildSiblingsDtos.getRequestBody();
        var result = this.childSiblingsService.addAll2(response);
        return ResponseEntity.ok(result);
    }

    @PutMapping(value = "update")
    public ResponseEntity<UpdatedChildSiblingsDto> update(@RequestBody @Valid UpdatedChildSiblingsDto updatedChildSiblingsDtos) throws Exception {
        var result = this.childSiblingsService.update(updatedChildSiblingsDtos);
        return ResponseEntity.ok(result);
    }

    @DeleteMapping(value = "delete/{childSiblingsId}")
    @ResponseBody
    public ResponseEntity<DeletedChildSiblingsDto> delete(@PathVariable String childSiblingsId) throws Exception {
        var result = this.childSiblingsService.delete2(childSiblingsId);
        return ResponseEntity.ok(result);
    }
}
