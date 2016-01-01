class Author < ActiveRecord::Base
	validates :id, presence: true, length: { minimum: 1 }
	validates :name, presence: true, length: { minimum: 1 }
	validates :about, presence: true, length: { minimum: 1 }
end
