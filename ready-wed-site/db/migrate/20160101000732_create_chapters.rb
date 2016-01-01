class CreateChapters < ActiveRecord::Migration
  def change
    drop_table :chapters if ActiveRecord::Base.connection.table_exists? :chapters
    create_table :chapters, id: false do |t|
      t.primary_key :id
      t.text :title, null: false
      t.text :summary, null: false

      t.timestamps null: false
    end
  end
end