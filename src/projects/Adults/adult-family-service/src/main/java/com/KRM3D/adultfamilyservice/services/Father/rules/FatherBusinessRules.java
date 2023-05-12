package com.KRM3D.adultfamilyservice.services.Father.rules;

import com.KRM3D.adultfamilyservice.entities.Father;
import com.KRM3D.adultfamilyservice.repositories.FatherRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class FatherBusinessRules {
    private FatherRepository fatherRepository;

    @Autowired
    public FatherBusinessRules(FatherRepository fatherRepository) {
        this.fatherRepository = fatherRepository;
    }
    public  void SetToUpper(Father father){
        father.setFirstName(father.getFirstName().toUpperCase());
        father.setLastName(father.getLastName().toUpperCase());
        father.setJob(father.getJob().toUpperCase());
        father.setHowManyChildHave(father.getHowManyChildHave().toUpperCase());
        father.setIsLiveWith(father.getIsLiveWith().toUpperCase());
    }
    public  void SetTrim(Father father){
        father.setFirstName(father.getFirstName().trim());
        father.setLastName(father.getLastName().trim());
        father.setJob(father.getJob().trim());
        father.setHowManyChildHave(father.getHowManyChildHave().trim());
        father.setIsLiveWith(father.getIsLiveWith().trim());
    }
}
