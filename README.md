# UtilityApp
This is a windows application which is made for many small utility purpose

1. Convert movie name to IMDB movie link, note not sure this is actually allowed by IMDB but this just for personal use so i guess its ok

Use the link below to get the IMDB json information on the title. Just replace the title name(in the variable q) with the one you want. Here the name is 'Bajirao Mastani'
http://www.imdb.com/xml/find?json=1&nr=1&tt=on&q=%27Bajirao Mastani%27

Then with the resultant json get the title id

{ "title_popular": [{ "id":"tt3735246", "title":"Bajirao Mastani", "name":"","title_description":"2015, Sanjay Leela Bhansali","episode_title":"","description":"2015, Sanjay Leela Bhansali"}],"title_exact": [{ "id":"tt0252257", "title":"Bajirao Mastani", "name":"","title_description":"1925, Nanubhai B. Desai...","episode_title":"","description":"1925, Nanubhai B. Desai..."},{ "id":"tt3304458", "title":"Bajirao Mastani", "name":"","title_description":"2012 short, Mizanur Rahman","episode_title":"","description":"2012 short, Mizanur Rahman"}],"title_approx": [{ "id":"tt0896832", "title":"Magtanim hindi biro", "name":"","title_description":"1940, Mar I. Esmeralda","episode_title":"","description":"1940, Mar I. Esmeralda"}] } 

Replace it in the link below, you get the link to the movie in IMDB.

http://www.imdb.com/title/tt3735246/

Used Newtonsoft.Json library for json
