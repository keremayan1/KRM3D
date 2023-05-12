package com.KRM3D.marriedstatusservice.services.dtos;

import lombok.Data;
import org.springframework.data.annotation.Id;

import javax.validation.constraints.NotBlank;
import javax.validation.constraints.NotNull;

@Data
public class CreatedMarriedStatusDto {

    @NotBlank(message = "Evlilik Alanı Boş Olamaz!")
    @NotNull(message = "Evlilik Alanı Boş Olamaz!")
    private String marriedStatusName;
}
