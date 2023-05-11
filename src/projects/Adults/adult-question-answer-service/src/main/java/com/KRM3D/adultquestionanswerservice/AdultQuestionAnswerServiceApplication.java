package com.KRM3D.adultquestionanswerservice;

import org.modelmapper.ModelMapper;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.annotation.Bean;

@SpringBootApplication
public class AdultQuestionAnswerServiceApplication {

	public static void main(String[] args) {
		SpringApplication.run(AdultQuestionAnswerServiceApplication.class, args);
	}
	@Bean
	public ModelMapper modelMapper(){
		return  new ModelMapper();
	}
}
