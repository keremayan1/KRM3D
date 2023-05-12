package com.KRM3D.marriedstatusservice.services.rules;

import com.KRM3D.marriedstatusservice.entities.MarriedStatus;
import com.KRM3D.marriedstatusservice.repositories.MarriedStatusRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class MarriedStatusBusinessRules {
    private MarriedStatusRepository marriedStatusRepository;

    @Autowired
    public MarriedStatusBusinessRules(MarriedStatusRepository marriedStatusRepository) {
        this.marriedStatusRepository = marriedStatusRepository;
    }
    public  void SetToUpper(MarriedStatus marriedStatus){
        marriedStatus.setMarriedStatusName(marriedStatus.getMarriedStatusName().toUpperCase());
    }
    public  void SetTrim(MarriedStatus marriedStatus){
        marriedStatus.setMarriedStatusName(marriedStatus.getMarriedStatusName().trim());
    }
}
