package com.krm3d.educationStatus.service.streams;

import org.springframework.cloud.stream.annotation.Output;
import org.springframework.messaging.MessageChannel;

public interface EducationStatusPublishChannel {
    String CREATE_OUTPUT_CHANNEL = "CreateEducationStatus";
    @Output(CREATE_OUTPUT_CHANNEL)
    MessageChannel createOutputChannel();
    String UPDATE_OUTPUT_CHANNEL = "UpdateEducationStatus";
    @Output(UPDATE_OUTPUT_CHANNEL)
    MessageChannel updateOutputChannel();

    String DELETE_OUTPUT_CHANNEL = "DeleteEducationStatus";
    @Output(DELETE_OUTPUT_CHANNEL)
    MessageChannel deleteOutputChannel();
}
