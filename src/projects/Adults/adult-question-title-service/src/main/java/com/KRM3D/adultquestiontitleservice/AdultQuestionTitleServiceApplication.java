package com.KRM3D.adultquestiontitleservice;

import org.modelmapper.ModelMapper;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.annotation.Bean;

@SpringBootApplication
public class AdultQuestionTitleServiceApplication {

	public static void main(String[] args) {
		SpringApplication.run(AdultQuestionTitleServiceApplication.class, args);
	}
	@Bean
	public ModelMapper modelMapper(){
		return new ModelMapper();
	}
}
