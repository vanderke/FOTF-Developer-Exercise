class Chapter < ActiveRecord::Base
    validates :id, presence: true, length: { minimum: 1 }
	validates :title, presence: true, length: { minimum: 1 }
	validates :summary, presence: true, length: { minimum: 1 }
end
