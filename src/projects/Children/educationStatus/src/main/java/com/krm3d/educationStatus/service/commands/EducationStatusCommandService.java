package com.krm3d.educationStatus.service.commands;

import com.krm3d.educationStatus.dto.CreatedEducationStatusDto;
import com.krm3d.educationStatus.dto.DeletedEducationStatusDto;
import com.krm3d.educationStatus.dto.UpdatedEducationStatusDto;
import com.krm3d.educationStatus.entity.EducationStatus;

public interface EducationStatusCommandService {
    CreatedEducationStatusDto createEducationStatus(CreatedEducationStatusDto educationStatus);
    UpdatedEducationStatusDto updateEducationStatus(UpdatedEducationStatusDto educationStatus);
    DeletedEducationStatusDto deleteEducationStatus(String id);
}
