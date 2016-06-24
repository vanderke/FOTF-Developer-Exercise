class Review < ActiveRecord::Base
  belongs_to :lesson
  
  validates :comment, presence: true
end
