class Lesson < ActiveRecord::Base
  has_many :reviews
  
  validates :chapter, presence: true
  validates :title, presence: true
  validates :summary, presence: true
end
