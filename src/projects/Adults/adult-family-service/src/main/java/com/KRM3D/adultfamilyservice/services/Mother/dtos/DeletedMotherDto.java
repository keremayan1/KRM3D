package com.KRM3D.adultfamilyservice.services.Mother.dtos;

import lombok.Data;
import org.springframework.data.annotation.Id;

@Data
public class DeletedMotherDto {
    @Id
    private String get_id;
}
