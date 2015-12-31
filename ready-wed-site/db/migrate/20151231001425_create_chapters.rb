class CreateChapters < ActiveRecord::Migration
  def change
    create_table :chapters, id: false do |t|
      t.text :id, null: false
      t.text :title, null: false
      t.text :summary, null: false

      t.timestamps null: false
    end
    #in effect, make id the primary key
    add_index :chapters, :id, unique: true
  end
end
