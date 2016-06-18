class Lesson < ActiveRecord::Base
  validates :chapter, presence: true
  validates :title, presence: true
  validates :summary, presence: true
end
