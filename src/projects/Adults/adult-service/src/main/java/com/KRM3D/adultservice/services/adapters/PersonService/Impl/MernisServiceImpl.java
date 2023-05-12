package com.KRM3D.adultservice.services.adapters.PersonService.Impl;

import com.KRM3D.adultservice.entities.Adult;
import com.KRM3D.adultservice.mernis.INJKPSPublicSoap;

import com.KRM3D.adultservice.services.adapters.PersonService.MernisService;
import org.springframework.stereotype.Service;

@Service

public class MernisServiceImpl implements MernisService {
    @Override
    public Boolean Verify(Adult adult) throws Exception {
        INJKPSPublicSoap client = new INJKPSPublicSoap();
       return client.TCKimlikNoDogrula(Long.valueOf(adult.getNationalId()),adult.getFirstName(),adult.getLastName(),adult.getDateOfBirth().getYear());
    }
}
