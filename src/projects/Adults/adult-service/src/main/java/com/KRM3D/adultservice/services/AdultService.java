package com.KRM3D.adultservice.services;


import com.KRM3D.adultservice.services.dtos.CreatedAdultDto;
import com.KRM3D.adultservice.services.dtos.DeletedAdultDto;
import com.KRM3D.adultservice.services.dtos.UpdatedAdultDto;

public interface AdultService {

    CreatedAdultDto add (CreatedAdultDto adult) throws Exception;
    UpdatedAdultDto update(UpdatedAdultDto adult) throws Exception;
    DeletedAdultDto delete(String adultId);
}
