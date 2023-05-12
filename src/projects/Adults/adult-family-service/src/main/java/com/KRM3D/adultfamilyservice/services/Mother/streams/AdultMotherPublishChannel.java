package com.KRM3D.adultfamilyservice.services.Mother.streams;

import org.springframework.cloud.stream.annotation.Output;
import org.springframework.messaging.MessageChannel;

public interface AdultMotherPublishChannel {
    String CREATE_OUTPUT_CHANNEL = "CreateAdultFamilyMother";
    @Output(CREATE_OUTPUT_CHANNEL)
    MessageChannel createOutputChannel();

    String UPDATE_OUTPUT_CHANNEL = "UpdateAdultFamilyMother";
    @Output(UPDATE_OUTPUT_CHANNEL)
    MessageChannel updateOutputChannel();

    String DELETE_OUTPUT_CHANNEL = "DeleteAdultFamilyMother";
    @Output(DELETE_OUTPUT_CHANNEL)
    MessageChannel deleteOutputChannel();
}
