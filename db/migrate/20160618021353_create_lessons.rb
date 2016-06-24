class CreateLessons < ActiveRecord::Migration
  def change
    create_table :lessons do |t|
      t.string :chapter
      t.string :title
      t.string :summary

      t.timestamps
    end
  end
end
