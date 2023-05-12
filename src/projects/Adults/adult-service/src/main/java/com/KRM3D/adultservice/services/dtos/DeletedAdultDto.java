package com.KRM3D.adultservice.services.dtos;

import lombok.Data;
import org.springframework.data.annotation.Id;

@Data
public class DeletedAdultDto {
    @Id
    private String _id;
}
