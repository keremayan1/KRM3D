package com.KRM3D.adultfamilyservice.services.Father;

import com.KRM3D.adultfamilyservice.services.Father.dtos.CreatedFatherDto;
import com.KRM3D.adultfamilyservice.services.Father.dtos.DeletedFatherDto;
import com.KRM3D.adultfamilyservice.services.Father.dtos.UpdatedFatherDto;

public interface FatherService {
    CreatedFatherDto add(CreatedFatherDto createdFatherDto);
    UpdatedFatherDto update(UpdatedFatherDto updatedFatherDto);
    String delete(String id);
}
