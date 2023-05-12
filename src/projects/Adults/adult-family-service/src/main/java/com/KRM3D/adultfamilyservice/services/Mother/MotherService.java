package com.KRM3D.adultfamilyservice.services.Mother;

import com.KRM3D.adultfamilyservice.services.Mother.dtos.CreatedMotherDto;
import com.KRM3D.adultfamilyservice.services.Mother.dtos.UpdatedMotherDto;

public interface MotherService {
    CreatedMotherDto add(CreatedMotherDto createdMotherDto);
    UpdatedMotherDto update(UpdatedMotherDto updatedMotherDto);
    String delete(String id);
}
