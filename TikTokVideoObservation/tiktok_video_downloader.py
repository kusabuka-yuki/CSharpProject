import yt_dlp
import sys
from kchobi_file_common.file_base import FileBase
from kchobi_logger.logger import Logger
import logging

file = FileBase()
readed_text = file.readlines_text("download_path.dat")
download_path = ""

loggerInstance = Logger("debug.log", "w")
loggerInstance.create_logger(__name__, logging.DEBUG)
logger = loggerInstance.logger

if(readed_text != False):
    if(len(readed_text) > 0):
        download_path = readed_text[0]

print(download_path)

def download_tiktok_video(url):
    logger.debug(url)

    try:
        ydl_opts = {
            'format': 'bv+ba/best',  # ベストビデオとベストオーディオを結合
            'outtmpl': f'{download_path}%(title)s.%(ext)s',  # 動画のタイトルでファイルを保存
            'postprocessors': [{
                'key': 'FFmpegVideoConvertor',
                'preferedformat': 'mp4',  # 出力フォーマットをmp4に設定
            }],
        }

        with yt_dlp.YoutubeDL(ydl_opts) as ydl:
            logger.debug("ダウンロードする")
            ydl.download([url])

        print("1")
    except Exception as e:
        # print(f"{e}")
        logger.error(e)
        print("0")
        raise
    return

if __name__ == "__main__":
    logger.debug(sys.argv)
    
    if len(sys.argv) <= 0 :
        print("0")
    
    print(sys.argv[1].split(","))
    # sys.argvの第一引数に渡された動画URLの文字列を分解する。
    # 文字列はカンマ区切りであることが前提。
    for url in sys.argv[1].split(","):
        try:
            download_tiktok_video(url)
        except:
            logger.error("例外発生")