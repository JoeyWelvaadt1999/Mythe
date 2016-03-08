using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class AlignUI : MonoBehaviour {
	[SerializeField]private Canvas _canvas;
	[Range(-100,100)][SerializeField]private int _percentageX;
	[Range(-100,100)][SerializeField]private int _percentageY;
	private RectTransform _canvasRect;
	private RectTransform _rect;

	void Start() {
		_canvasRect = _canvas.GetComponent<RectTransform> ();
		_rect = GetComponent<RectTransform> ();
		_rect.anchoredPosition = CalculatePosition ();
	}

	public Vector2 CalculatePosition() {
		_canvasRect = _canvas.GetComponent<RectTransform> ();
		_rect = GetComponent<RectTransform> ();
		float x = 0 + ((_canvasRect.rect.width / 2) / _percentageX - (_rect.rect.width / 2) / _percentageX);
		float y = 0 + ((_canvasRect.rect.height / 2) / _percentageY - (_rect.rect.height / 2) / _percentageY);
		_rect.anchoredPosition = new Vector2(x, y);
		return new Vector2 (x, y);
	}


	void OnValidate() {
		if (_percentageX == 0) {
			_percentageX = 1;

		}

		if (_percentageY == 0) {
			_percentageY = 1;
		}
	}
}
