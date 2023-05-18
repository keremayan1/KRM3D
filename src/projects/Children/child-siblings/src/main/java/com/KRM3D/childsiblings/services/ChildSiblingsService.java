package com.KRM3D.childsiblings.services;

import com.KRM3D.childsiblings.dtos.CreatedChildSiblingsDto;
import com.KRM3D.childsiblings.dtos.DeletedChildSiblingsDto;
import com.KRM3D.childsiblings.dtos.UpdatedChildSiblingsDto;


import java.util.List;

public interface ChildSiblingsService {
    CreatedChildSiblingsDto add(CreatedChildSiblingsDto createdChildSiblingsDto);
    List<CreatedChildSiblingsDto> addAll(List<CreatedChildSiblingsDto> createdChildSiblingsDto) throws Exception;
    List<CreatedChildSiblingsDto> addAll2(List<CreatedChildSiblingsDto> createdChildSiblingsDto) throws Exception;
    UpdatedChildSiblingsDto update(UpdatedChildSiblingsDto updatedChildSiblingsDto);
    DeletedChildSiblingsDto delete(DeletedChildSiblingsDto deletedChildSiblingsDto);
    DeletedChildSiblingsDto delete2(String childSiblingsId);

}
