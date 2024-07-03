using OnlineHub.WebUI.Interfaces;

namespace OnlineHub.WebUI.Helpers
{
    public class FileHelper : IFileHelper
    {
        IWebHostEnvironment _env;
        public FileHelper(IWebHostEnvironment _env)
        {
            this._env = _env;
        }
        public void DeleteFile(string imageUrl)
        {
            if (File.Exists(_env.WebRootPath + imageUrl))
            {
                File.Delete(_env.WebRootPath + imageUrl);
            }
        }

        public string UploadFile(IFormFile file)
        {
            var uploads = Path.Combine(_env.WebRootPath, "images");
            var exists = Directory.Exists(uploads);
            if (!exists)
                Directory.CreateDirectory(uploads);

            //Save File
            string filename = GenerateFileName(file.FileName);
            var fileStream = new FileStream(Path.Combine(uploads, filename), FileMode.Create);
            file.CopyToAsync(fileStream);
            return "/images/" + filename;
        }
        private string GenerateFileName(string filename)
        {
            string[] strName = filename.Split('.');
            string strFilename = DateTime.Now.ToUniversalTime().ToString("yyyyMMdd\\THHmmssfff") + "." + strName[strName.Length - 1];
            return strFilename;
        }
    }
}
