package com.KRM3D.marriedstatusservice.services.dtos;

import lombok.Data;
import org.springframework.data.annotation.Id;

@Data
public class DeletedMarriedStatusDto {
    @Id
    private String get_id;

}
