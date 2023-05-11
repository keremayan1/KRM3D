package com.krm3d.childSiblings.services;

import com.krm3d.childSiblings.dtos.CreatedChildSiblingsDto;
import com.krm3d.childSiblings.dtos.DeletedChildSiblingsDto;
import com.krm3d.childSiblings.dtos.UpdatedChildSiblingsDto;

import java.util.List;

public interface ChildSiblingsService {
    CreatedChildSiblingsDto add(CreatedChildSiblingsDto createdChildSiblingsDto);
    List<CreatedChildSiblingsDto> addAll(List<CreatedChildSiblingsDto> createdChildSiblingsDto) throws Exception;
    List<CreatedChildSiblingsDto> addAll2(List<CreatedChildSiblingsDto> createdChildSiblingsDto) throws Exception;
    UpdatedChildSiblingsDto update(UpdatedChildSiblingsDto updatedChildSiblingsDto);
    DeletedChildSiblingsDto delete(DeletedChildSiblingsDto deletedChildSiblingsDto);
    DeletedChildSiblingsDto delete2(String childSiblingsId);

}
