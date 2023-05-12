package com.KRM3D.adultfamilyservice.services.Siblings;

import com.KRM3D.adultfamilyservice.services.Siblings.dtos.CreatedSiblingsDto;
import com.KRM3D.adultfamilyservice.services.Siblings.dtos.UpdatedSiblingsDto;

import java.util.List;

public interface SiblingsService {
    List<CreatedSiblingsDto> add(List<CreatedSiblingsDto> createdSiblingsDto);
    UpdatedSiblingsDto update(UpdatedSiblingsDto updatedSiblingsDto);
    String delete(String id);
}
