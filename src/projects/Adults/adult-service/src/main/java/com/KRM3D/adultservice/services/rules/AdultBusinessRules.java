package com.KRM3D.adultservice.services.rules;

import com.KRM3D.adultservice.entities.Adult;
import com.KRM3D.adultservice.repositories.AdultRepository;
import com.KRM3D.adultservice.services.adapters.PersonService.MernisService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class AdultBusinessRules {
    private MernisService mernisService;
    private AdultRepository adultRepository;


    @Autowired
    public AdultBusinessRules(MernisService mernisService, AdultRepository adultRepository) {
        this.mernisService = mernisService;
        this.adultRepository = adultRepository;
    }
    public  void SetToUpper(Adult adult){
        adult.setFirstName(adult.getFirstName().toUpperCase());
        adult.setLastName(adult.getLastName().toUpperCase());
        adult.setJob(adult.getJob().toUpperCase());
        adult.setDidSheHeComeWith(adult.getDidSheHeComeWith().toUpperCase());
        adult.setEthnicName(adult.getEthnicName().toUpperCase());
        adult.setIsLiveWith(adult.getIsLiveWith().toUpperCase());
        adult.setPersonComesFromHere(adult.getPersonComesFromHere().toUpperCase());
        adult.setReligionName(adult.getReligionName().toUpperCase().toUpperCase());
        adult.setReasonOfApplication(adult.getReasonOfApplication().toUpperCase());
    }
    public  void SetTrim(Adult adult){
        adult.setFirstName(adult.getFirstName().trim());
        adult.setLastName(adult.getLastName().trim());
        adult.setJob(adult.getJob().trim());
        adult.setDidSheHeComeWith(adult.getDidSheHeComeWith().trim());
        adult.setEthnicName(adult.getEthnicName().trim());
        adult.setIsLiveWith(adult.getIsLiveWith().trim());
        adult.setPersonComesFromHere(adult.getPersonComesFromHere().trim());
        adult.setReligionName(adult.getReligionName().trim());
        adult.setReasonOfApplication(adult.getReasonOfApplication().trim());
    }
    public void VerifyNationalId(Adult adult) throws Exception {
        var isRealPerson = this.mernisService.Verify(adult);
        if (!isRealPerson) {
            throw new Exception("Kimlik Bilgileri Hatalıdır");
        }
    }

    public void CheckIfNationalIdExists(String nationalId) throws Exception {
        var result = this.adultRepository.findByNationalId(nationalId);
        if (result!=null){
        throw new Exception("Kullanici Sistemde Var");
        }

    }
}
