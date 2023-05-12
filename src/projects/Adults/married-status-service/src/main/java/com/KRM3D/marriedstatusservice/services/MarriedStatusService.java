package com.KRM3D.marriedstatusservice.services;

import com.KRM3D.marriedstatusservice.services.dtos.CreatedMarriedStatusDto;
import com.KRM3D.marriedstatusservice.services.dtos.UpdatedMarriedStatusDto;

public interface MarriedStatusService {
    CreatedMarriedStatusDto add(CreatedMarriedStatusDto createdMarriedStatusDto);
    UpdatedMarriedStatusDto update(UpdatedMarriedStatusDto updatedMarriedStatusDto);
    String delete(String id);
}
