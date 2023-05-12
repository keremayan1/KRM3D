package com.KRM3D.adultfamilyservice.services.Siblings.dtos;

import lombok.Data;
import org.springframework.data.annotation.Id;

@Data
public class DeletedSiblingsDto {
    @Id
    private String get_id;

}
