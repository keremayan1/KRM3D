package com.KRM3D.marriedstatusservice.entities;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;
import org.springframework.data.annotation.Id;

@Data
@NoArgsConstructor
@AllArgsConstructor
public class MarriedStatus {
    @Id
    private String _id;
    private String marriedStatusName;
}
