#Purpose/Preamble:

#we need a python script to manage metadata of MP3s
#eyeD3 is great for mp3-specific ID3 handling
#if we convert all recieved files into easy-to-store mp3s, we can add perfect ID3 tags to all files!
#we will need to use ffmpeg as well, but it'll be really easy to work with from hereon out

#Actual Code:

#eyeD3 as primary library for metadata access
#https://eyed3.readthedocs.io/en/latest/installation.html
#shell:
#$ pip install eyeD3

#ffmpeg as library for converting non-mp3 files
#https://ffmpeg.org/download.html
#figure out how to get this in the bot thanks

import eyeD3
#initiaizing new tag and file
tag = eyeD3.Tag()
tag.link("C:/Users/Ember/Music/ABSRDST/)
#printing existing tags
print tag.getArtist()
print tag.getAlbum()
print tag.getTitle()

#read an mp3 and access its tag
if eyeD3.isMp3File(f):
     audioFile = eyeD3.Mp3AudioFile(f)
     tag = audioFile.getTag()

#specific tag versions can be selected:
tag.link("/some/file.mp3", eyeD3.ID3_V2)
 tag.link("/some/file.mp3", eyeD3.ID3_V1)
 tag.link("/some/file.mp3", eyeD3.ID3_ANY_VERSION)  # The default.	

#Once a tag is linked to a file it can be modified and saved:
 tag.setArtist(u"Cro-Mags")
 tag.setAlbum(u"Age of Quarrel")
 tag.update()

#Read in a tag and remove it from the file:
 tag.link("/some/file.mp3")
 tag.remove()
 tag.update()

#add a new tag
 tag = eyeD3.Tag()
 tag.link('/some/file.mp3')    # no tag in this file, link returned False
 tag.header.setVersion(eyeD3.ID3_V2_3)
 tag.setArtist('Fugazi')
 tag.update()

#thanks https://stackoverflow.com/questions/8948/accessing-mp3-meta-data-with-python

#MUTAGEN:
#mutagen COULD be used
#it has an easy ID3 mode:
import mutagen

from mutagen.easyid3 import EasyID3

audio = EasyID3("example.mp3")
audio['title'] = u"Example Title"
audio['artist'] = u"Me"
audio['album'] = u"My album"
audio['composer'] = u"" # clear
audio.save()

#but there's so much more to deal with different file types that I'd rather just use ffmpeg to convert to mp3
#https://mutagen.readthedocs.io/en/latest/

#windows playback of sounds
import winsound

winsound.PlaySound('sound.wav', winsound.SND_FILENAME)

#linux playback of sounds using OSS
from wave import open as waveOpen
from ossaudiodev import open as ossOpen
s = waveOpen('tada.wav','rb')
(nc,sw,fr,nf,comptype, compname) = s.getparams( )
dsp = ossOpen('/dev/dsp','w')
try:
  from ossaudiodev import AFMT_S16_NE
except ImportError:
  from sys import byteorder
  if byteorder == "little":
    AFMT_S16_NE = ossaudiodev.AFMT_S16_LE
  else:
    AFMT_S16_NE = ossaudiodev.AFMT_S16_BE
dsp.setparameters(AFMT_S16_NE, nc, fr)
data = s.readframes(nf)
s.close()
dsp.write(data)
dsp.close()