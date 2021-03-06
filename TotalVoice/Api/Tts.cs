﻿namespace TotalVoice.Api
{
    public class Tts : Api
    {
        public const string ROTA_TTS = "tts";

        public Tts(TotalVoiceClient Client) : base(Client)
        {
        }

        public string Enviar(string data)
        {
            Path path = new Path();
            path.Add(ROTA_TTS);

            _request.SetPath(path);
            _request.SetBody(data);
            return _client.SendRequest(_request, "POST");
        }

        public string Buscar(int Id)
        {
            Path path = new Path();
            path.Add(ROTA_TTS);
            path.Add(Id);

            _request.SetPath(path);
            return _client.SendRequest(_request, "GET");
        }

        public string Relatorio(string data)
        {
            Path path = new Path();
            path.Add(ROTA_TTS);
            path.Add("relatorio");

            _request.SetPath(path);
            return _client.SendRequest(_request, "GET");
        }
    }
}
