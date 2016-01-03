class User < ActiveRecord::Base
	before_save { self.email = email.downcase }
	VALID_EMAIL_REGEX = /\A[\w+\-.]+@[a-z\d\-.]+\w+\.[a-z]+\z/i
	#Match start of string, one or more word character plus hyphen or dot, literal at sign, one or more letter digit hyphen or dot, one or more word character, literal dot, one or more letter, end of string
	validates :name, presence: true, length: { maximum: 50 }
	validates :email, presence: true,
			   		  length: { maximum: 255 },
			   		  format: { with: VALID_EMAIL_REGEX},
			    	  uniqueness: { case_sensitive: false }
	validates :password, presence: true,
						 length: { minimum: 8 }
	has_secure_password
end
